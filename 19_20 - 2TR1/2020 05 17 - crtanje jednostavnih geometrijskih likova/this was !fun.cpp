#define _CRT_SECURE_NO_WARNINGS
#include <freeglut.h>
#include <stdlib.h>
#include <math.h>
#include <stdio.h>

#define PI 3.1415926535897932384626433832795
#define WIDTH 1000
#define HEIGHT 1000

float degs[] = { 45.0, 180.0, 90.0, 180.0 };

void display();

int main(int argc, char **argv)
{
	glutInit(&argc, argv);
	glutInitDisplayMode(GLUT_DOUBLE | GLUT_RGBA | GLUT_DEPTH);
	glutInitWindowSize(WIDTH, HEIGHT);
	glutInitWindowPosition(50, 50);
	glutCreateWindow("AiP - vjezba 29 - N.M.");
	
	glClearColor(1.0, 1.0, 1.0, 0.0);
	glOrtho(0, WIDTH, HEIGHT, 0, -1, 1);
	glLoadIdentity();

	glutDisplayFunc(display);
	glutMainLoop();

	return 0;
}

void display()
{
	glClear(GL_COLOR_BUFFER_BIT);
	
	double radius = 0.45;

	glPushMatrix();
		{
			// KRUG GORE LEVO
			glTranslatef(-0.5, 0.5, 0);
			{
				{
					glColor3d(0, 0, 0);
					glBegin(GL_POLYGON);

					for (double i = 0; i < 2 * PI; i += PI / 36)
						glVertex2f(cos(i) * radius, sin(i) * radius);

					glEnd();
				}
					radius -= 0.015;
				{
					glColor3d(255, 255, 255);
					glBegin(GL_POLYGON);

					for (double i = 0; i < 2 * PI; i += PI / 36)
						glVertex2f(cos(i) * radius, sin(i) * radius);

					glEnd();
				}
					radius -= 0.015;
				{
					glColor3d(255, 0, 0);
					glBegin(GL_POLYGON);

					for (double i = 0; i < 2 * PI; i += PI / 36)
						glVertex2f(cos(i) * radius, sin(i) * radius);

					glEnd();
				}
					radius -= 0.125;
				{
					glColor3d(0, 0, 255);
					glBegin(GL_POLYGON);

					for (double i = 0; i < 2 * PI; i += PI / 36)
						glVertex2f(cos(i) * radius, sin(i) * radius);

					glEnd();
				}

				{
					glColor3d(255, 0, 0);
					float rectangleWidth = radius + 0.07;
					float rectangleHeight = radius + 0.07;

					glLineWidth(60);
					
					for (int i = 0; i < 4; ++i)
					{
						glRotatef(degs[i], 0.0, 0.0, 1.0);

						glBegin(GL_LINE_STRIP);
							glVertex2f(0, 0);
							glVertex2f(0 + rectangleWidth, 0);
						glEnd();
					}
				}
			}
		}

		glRotatef(-180, 0, 0, 0);
		radius = 0.45;

		{
			// KRUG GORE DESNO
			glTranslatef(0.7, 0.7, 0);
			{
				{
					glColor3d(0, 0, 0);
					glBegin(GL_POLYGON);

					for (double i = 0; i < 2 * PI; i += PI / 36)
						glVertex2f(cos(i) * radius, sin(i) * radius);

					glEnd();
				}
				radius -= 0.015;
				{
					glColor3d(255, 255, 255);
					glBegin(GL_POLYGON);

					for (double i = 0; i < 2 * PI; i += PI / 36)
						glVertex2f(cos(i) * radius, sin(i) * radius);

					glEnd();
				}
				radius -= 0.015;
				{
					glColor3d(255, 0, 0);
					glBegin(GL_POLYGON);

					for (double i = 0; i < 2 * PI; i += PI / 36)
						glVertex2f(cos(i) * radius, sin(i) * radius);

					glEnd();
				}
				radius -= 0.125;
				{
					glColor3d(255, 255, 255);
					glBegin(GL_POLYGON);

					for (double i = 0; i < 2 * PI; i += PI / 36)
						glVertex2f(cos(i) * radius, sin(i) * radius);

					glEnd();
				}
			}
		}

		glRotatef(180, 0, 0, 0);
		radius = 0.45;

		{
			// KRUG DOLE LEVO
			glTranslatef(0.0, 1.4, 0);
			{
				{
					glColor3d(255, 0, 0);
					glBegin(GL_POLYGON);

					for (double i = 0; i < 2 * PI; i += PI / 36)
						glVertex2f(cos(i) * radius, sin(i) * radius);

					glEnd();
				}
				radius -= 0.015;
				{
					glColor3d(255, 255, 255);
					glBegin(GL_POLYGON);

					for (double i = 0; i < 2 * PI; i += PI / 36)
						glVertex2f(cos(i) * radius, sin(i) * radius);

					glEnd();
				}
				radius -= 0.015;
				{
					glColor3d(255, 0, 0);
					glBegin(GL_POLYGON);

					for (double i = 0; i < 2 * PI; i += PI / 36)
						glVertex2f(cos(i) * radius, sin(i) * radius);

					glEnd();
				}
				radius -= 0.05;
				{
					glColor3d(255, 255, 255);
					glLineWidth(75);

					glRotatef(45, 0.0, 0.0, 1.0);

					glBegin(GL_LINE_STRIP);

					glVertex2f(0, 0);
					glVertex2f(0 + radius, 0);

					glRotatef(180, 0, 0, 0);

					glVertex2f(0, 0);
					glVertex2f(0 - radius, 0);

					glEnd();
				}
			}
		}

		{
			// KRUG DOLE DESNO
			glTranslatef(-1.325, -0.325, 0);
			{
				glRotatef(45, 0, 0, 0.01);
				glTranslatef(0.1, -0.335, 1);
				{
					glColor3d(0, 0, 0);
					glRectd(0, 0, 0.7, 0.7);
				}

				{
					glColor3d(255, 255, 255);
					glRectd(0.02, 0.02, 0.68, 0.68);
				}

				{
					glColor3d(0, 0, 0);
					glRectd(0.13, 0.13, 0.55, 0.55);
				}

				{
					glColor3d(255, 255, 0);
					glRectd(0.15, 0.15, 0.53, 0.53);
				}
			}
		}

	glPopMatrix();

	glFlush();
	glutSwapBuffers();
}

