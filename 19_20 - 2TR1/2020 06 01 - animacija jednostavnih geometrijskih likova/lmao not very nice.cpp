
// Includes
#include <freeglut.h>
#include <stdlib.h>
#include <math.h>
#include <stdio.h>

// Defines
#define PI 3.1415926535897932384626433832795
#define WIDTH 1000
#define HEIGHT 500

// Movement Enum
enum Movement
{
	x,
	y,
	z,
	rot
};

// PROTOTYPES
void initializeGlut(int* fa, char** sa);
void reshape(int width, int height);
void display();
void glutFunctSetup();
void timer(int);

// Animations
void drawBG();
void drawCar();
void drawSun();

// Movement Translators
void glutTranslator(Movement, GLdouble);
void glutResetPos();

GLdouble val_x = 0, val_y = 0, val_z = 0;
GLdouble val_rot = 0;


// Things Coordinates
GLfloat car_x = -0.95;
GLfloat sun_cp = -1; // Sun arc = 0.3
GLdouble sun_i = 0;


int main(int fa, char **sa)
{
	initializeGlut(&fa, sa);
	glutFunctSetup();

	system("pause");
	return 0;
}

void initializeGlut(int* fa, char** sa)
{
	glutInit(fa, sa);
	glutInitDisplayMode(GLUT_DOUBLE | GLUT_RGBA);
	glutInitWindowSize(WIDTH, HEIGHT);
	glutInitWindowPosition(0, 0);

	glutCreateWindow("VJEZBA 31");

	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();

	gluOrtho2D(0, WIDTH, 0, HEIGHT);
	glLoadIdentity();

	glMatrixMode(GL_MODELVIEW);
	glLoadIdentity();
}

void reshape(int width, int height)
{
	glViewport(0, 0, width, height);
}

void display()
{
	glClear(GL_COLOR_BUFFER_BIT);
	glPushMatrix();

	{
		drawBG();
		drawCar();
		if (sun_i > 90 && sun_i <= 180) drawSun();
	}

	glPopMatrix();
	glFlush();
	glutSwapBuffers();
}

void glutFunctSetup()
{
	glutTimerFunc(0, timer, 0);
	glutDisplayFunc(display);
	glutReshapeFunc(reshape);
	glutMainLoop();
}

void drawBG()
{
	// MAKE BG BLUE CUZ SUN IS HERE
	if (sun_i > 90 && sun_i <= 180) glColor3ub(135, 210, 255);
	else glColor3ub(0, 0, 0);

	glRectd(-1, 1, 1, -1);


	// DRAW THE GROUND
	glClearColor(0.0, 0.0, 0.0, 0.0);
	glColor3ub(100, 75, 45);

	glutTranslator(y, -0.5);
	glRectd(0, 0, -1, -1);
	glRectd(0, 0, 1, -1);

	// DRAW THE GRASS
	glColor3ub(0, 255, 0);
	glRectd(-1, 0, 1, 0.1);

	// Places centerpoint on the middle part above the grass
	glutTranslator(y, 0.1);

}

void drawCar()
{
	// DRAW THE CAR
	glColor3ub(255, 0, 0);
	glRectd(car_x, 0.1, car_x + 0.25, 0.3);

	// Put glut at middle point of car, 0.1 below
	glutTranslator(x, car_x + 0.125);

	// DRAW THE WHEELS OF THE CAR
	glColor3ub(255, 255, 0);

	glutTranslator(x, -0.1);
	glutTranslator(y, 0.05);

	glBegin(GL_POLYGON);
	for (double i = 0; i < 2 * PI; i += PI / 36)
		glVertex2f(cos(i) * 0.025, sin(i) * 0.05);
	glEnd();

	glutTranslator(x, 0.195);

	glBegin(GL_POLYGON);
	for (double i = 0; i < 2 * PI; i += PI / 36)
		glVertex2f(cos(i) * 0.025, sin(i) * 0.05);
	glEnd();

	glutResetPos();
}

void drawSun()
{
	glutTranslator(x, -0.6); glutTranslator(y, 1);
	glColor3ub(255, 255, 0);

	glutTranslator(x, -(0.4 / 90) * (sun_i - 90));
	glutTranslator(y, -(0.4 / 90) * (sun_i - 90));

	glBegin(GL_POLYGON);
	for (int i = 0; i < 360; ++i)
		glVertex2f(cos(i * PI / 180) * 0.1, sin(i * PI / 180) * 0.2);
	glEnd();

	glutResetPos();
}

void timer(int)
{
	glutPostRedisplay();
	glutTimerFunc(100 / 9, timer, 0);

	if (car_x < 1)
		car_x += 0.01;
	else
		car_x = -1;

	if (sun_i < 360)
		sun_i += 0.5;
	else
		sun_i = 0;
}

void glutTranslator(Movement opt, GLdouble val)
{
	switch (opt)
	{
	case x:
		val_x += val;
		glTranslatef(val, 0, 0);
		break;
	case y:
		val_y += val;
		glTranslatef(0, val, 0);
		break;
	case z:
		val_z += val;
		glTranslatef(0, 0, val);
		break;
	case rot:
		val_rot += val;
		glRotatef(val, 0.0, 0.0, 0);
		break;
	}
}

void glutResetPos()
{
	glRotatef((val_rot * -1), 0, 0, 0);
	glTranslatef((val_x * -1), (val_y * -1), (val_z * -1));

	val_x = 0;
	val_y = 0;
	val_z = 0;


	val_rot = 0;
}