#define _CRT_SECURE_NO_WARNINGS
#include <freeglut.h>
#include <stdlib.h>
#include <math.h>
#include <stdio.h>

#define PI 3.1415926535897932384626433832795
#define WIDTH 800
#define HEIGHT 640

void display();
void reshape(int, int);

int main(int argc, char **argv)
{
	glutInit(&argc, argv);
	glutInitDisplayMode(GLUT_DOUBLE | GLUT_RGBA);
	glutInitWindowSize(WIDTH, HEIGHT);
	glutInitWindowPosition(0, 0);

	glutCreateWindow("AiP - vjezba 30 - N.M.");

	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();
	
	gluOrtho2D(0, WIDTH, 0, HEIGHT);
	glLoadIdentity();
	
	glMatrixMode(GL_MODELVIEW);
	glLoadIdentity();

	glutDisplayFunc(display);
	glutReshapeFunc(reshape);
	glutMainLoop();

	return 0;
}

void reshape(int width, int height)
{
	glViewport(0, 0, width, height);
}

void display()
{
	glClear(GL_COLOR_BUFFER_BIT);

	double radius = 0.25; // Circle radius

	glPushMatrix();
	{
		// JAPAN
		{
			// Draws the white rectangle
			{
				glColor3d(255, 255, 255);
				glRectd(0.005, 0.005, 1, 1);
			}

			// Move from center point half-way up and half-way right
			glTranslatef(0.5, 0.5, 0);

			// Drawing the Circle
			{
				glColor3d(255, 0, 0);
				glBegin(GL_POLYGON);

				for (double i = 0; i < 2 * PI; i += PI / 36)
					glVertex2f(cos(i) * radius, sin(i) * radius);

				glEnd();
			}
		}

		// BACK TO CENTER POINT
		glTranslatef(-0.5, -0.5, 0);

		// AUSTRIA
		{
			// Draws the white rectangle (background)
			{
				glColor3d(255, 255, 255);
				glRectd(-0.005, -0.005, -1, -1);
			}

			// Draws the first red box
			{
				glColor3d(255, 0, 0);
				glRectd(-0.005, -0.005, -1, -0.35);
			}

			// Drops down to the next red box (-0.35 + 0.3 spacing for white)
			glTranslatef(0, -0.65, 0);

			// Draws the first red box
			{
				glColor3d(255, 0, 0);
				glRectd(-0.005, 0.00, -1, -0.35);
			}
		}

		// BACK TO CENTER POINT
		glTranslatef(0, 0.65, 0);

		// DANSK
		{
			// Draws the white rectangle (background)
			{
				glColor3d(255, 255, 255);
				glRectd(0.005, -0.005, 1, -1);
			}

			glColor3d(255, 0, 0);
			// Draws the first little red rectangle
			{
				glRectd(0.005, -0.005, 0.3, -0.45);
			}

			// Drops down for the next red box (-0.45 - 0.1 spacing for white)
			glTranslatef(0, -0.55, 0);

			// Draws the second little red rectangle
			{
				glRectd(0.005, 0.00, 0.3, -0.45);
			}

			// Moves over the white spacing (0.3 + 0.1)
			glTranslatef(0.4, 0, 0);

			// Draws the bottom right rectangle
			{
				glRectd(0.005, 0.00, 0.6, -0.45);
			}

			// Moves over the white spacing (UP 0.55)
			glTranslatef(0, 0.55, 0);

			// Draws the top right rectangle
			{
				glRectd(0.005, -0.005, 0.6, -0.45);
			}
		}

		// BACK TO CENTER POINT
		glTranslatef(-0.4, 0, 0);

		// CZECH
		{
			// Draws the white rectangle (background)
			{
				glColor3d(255, 255, 255);
				glRectd(-0.005, 0.005, -1, 1);
			}

			// Draws red rectangle
			{
				glColor3d(255, 0, 0);
				glRectd(-0.005, 0.005, -0.5, 0.5);
			}

			// Now we're left with two triangles to take care of.

			// Moves to draw the red triangle
			glTranslatef(-0.5005, 0.005, 0);

			// Draws the red triangle
			{
				glBegin(GL_TRIANGLES);
					glVertex3f(0, 0.5, 0);			// top point
					glVertex3f(-0.5, 0, 0);			// bottom left
					glVertex3f(0, 0, 0);			// bottom right
				glEnd();
			}

			// Moves to draw the blue triangle
			glTranslatef(-0.5, 0, 0);

			// Draws the blue triangle
			{
				glColor3d(0, 0, 255);

				glBegin(GL_TRIANGLES);
					glVertex3f(0, 1.005, 0);		// top point
					glVertex3f(0, 0, 0);			// bottom left
					glVertex3f(0.495, 0.495, 0);	// bottom right
				glEnd();
			}
		}
	}
	glPopMatrix();

	glFlush();
	glutSwapBuffers();
}