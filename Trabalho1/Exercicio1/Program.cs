using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;
using Tao.FreeGlut;

namespace Exercicio1
{
    class Program
    {
        static void Inicializa()
        {
            Gl.glClearColor(0.0f, 0.0f, 0.0f, 0.0f); 
        }
        static void DesenhaLineStrip()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            Gl.glLineWidth(10);
            Gl.glColor3f(0.0f, 1.0f, 0.0f);
            Gl.glBegin(Gl.GL_LINE_STRIP);
            Gl.glVertex2f(0.5f, 0.2f);
            Gl.glVertex2f(-0.7f, -0.5f);
            Gl.glVertex2f(-0.5f, 0.6f);
            Gl.glEnd();

            Gl.glFlush();
        }

        static void DesenhaLineLoop()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            Gl.glLineWidth(10);
            Gl.glColor3f(1.0f, 1.0f, 0.0f);
            Gl.glBegin(Gl.GL_LINE_LOOP);
            Gl.glVertex2f(0.3f, 0.5f);
            Gl.glVertex2f(-0.3f, -0.5f);
            Gl.glVertex2f(0.4f, -0.4f);
            Gl.glEnd();

            Gl.glFlush();
        }

        static void DesenhaTriangulo()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glColor3f(1.0f, 1.0f, 0.0f);
            Gl.glBegin(Gl.GL_TRIANGLES);
            Gl.glVertex2f(0.1f, 0.6f);
            Gl.glVertex2f(0.2f, 0.8f);
            Gl.glVertex2f(0.3f, 0.6f);
            Gl.glEnd();

            Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_LINE);
            Gl.glBegin(Gl.GL_TRIANGLES);
            Gl.glVertex2f(0.3f, 0.1f);
            Gl.glVertex2f(0.4f, 0.3f);
            Gl.glVertex2f(0.5f, 0.1f);
            Gl.glEnd();

            Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_FILL);
            Gl.glBegin(Gl.GL_TRIANGLES);
            Gl.glColor3f(1.0f, 0.0f, 0.0f);
            Gl.glVertex2f(0.5f, 0.6f);
            Gl.glColor3f(0.0f, 1.0f, 0.0f);
            Gl.glVertex2f(0.6f, 0.8f);
            Gl.glColor3f(1.0f, 0.0f, 0.0f);
            Gl.glVertex2f(0.7f, 0.6f);
            Gl.glEnd();

            Gl.glFlush();
        }

        static void Main(string[] args)
        {
            Glut.glutInit(); 
            Glut.glutInitDisplayMode(Glut.GLUT_SINGLE | Glut.GLUT_RGB);

            Glut.glutCreateWindow("Exercicio 1"); 

            Inicializa();

            Glut.glutDisplayFunc(DesenhaTriangulo); //Alterar para o desenho desejado

            Glut.glutMainLoop(); 
        }

        
    }
}
