using System;
using System.Collections;
namespace Ejercicio2Tema3
{
    class Aula
    {
        private int[,] notas = new int[12, 4];
        public int this[int indice, int indice2]
        {
            set
            {
                notas[indice, indice2] = value;
            }
            get
            {
                return notas[indice, indice2];
            }
        }

        public void Rellenar()
        {
            Random genereador = new Random();

            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    int nota = genereador.Next(0, 100);
                    switch (nota)
                    {
                        case int a when nota < 5:
                            nota = 0;
                            break;
                        case int a when nota >= 5 && nota <= 9:
                            nota = 1;
                            break;
                        case int a when nota > 9 && nota <= 14:
                            nota = 2;
                            break;
                        case int a when nota > 14 && nota <= 24:
                            nota = 3;
                            break;
                        case int a when nota > 24 && nota <= 39:
                            nota = 4;
                            break;
                        case int a when nota > 39 && nota <= 54:
                            nota = 5;
                            break;
                        case int a when nota > 54 && nota <= 69:
                            nota = 6;
                            break;
                        case int a when nota > 69 && nota <= 79:
                            nota = 7;
                            break;
                        case int a when nota > 79 && nota <= 89:
                            nota = 8;
                            break;
                        case int a when nota > 89 && nota <= 94:
                            nota = 9;
                            break;
                        case int a when nota > 94 && nota <= 99:
                            nota = 10;
                            break;
                    }
                    this[i, j] = nota;
                }
            }
        }
        public double CalcularMediasTotal()
        {
            double media = 0;
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    media = media + this[i, j];
                }
            }
            media = media / notas.Length;// (notas.GetLength(0) * notas.GetLength(1));
            return media;
        }
        public double CalcularMediaAl(int alu)
        {
            int media = 0;
            for (int i = 0; i < notas.GetLength(1); i++)
            {
                media = media + this[alu, i];
            }
            media = media / notas.GetLength(1);
            return media;
        }
        public double CalcularMediaAsig(int asig)
        {
            int media = 0;
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                media = media + this[i, asig];
            }
            media = media / notas.GetLength(0);
            return media;
        }
        public String VisualizarAluc(int alu, String[] nombres) // NO UI
        {
            String visual = "";
            visual = visual + String.Format("Alumno: {0}\n", nombres[alu]);
            foreach (asignaturas asig in Enum.GetValues(typeof(asignaturas)))
            {
                visual = visual + String.Format("{0,10}\t", asig);
            }
            visual = visual + "\n";
            for (int i = 0; i < notas.GetLength(1); i++)
            {
                visual = visual + String.Format("{0,10}\t", this[alu, i]);
            }
            visual = visual + "\n";
            return visual;
        }
        public String VisualizarAsig(int alu, asignaturas asig, String[] nombres)
        {
            String visual = "";
            visual = visual + String.Format("Notas Asignatura: {0}\n", asig);
            visual = visual + "\n";
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                visual = visual + String.Format("{0,10}\t{1}\n", nombres[i], this[i, (int)asig]);
            }
            return visual;
        }
        public int NotaMaxMinAl(int alumno, ref int minimo, ref asignaturas asigmaxi, ref asignaturas asigmini) //Parametros referencia max y min
        {
            int max = 0;
            int min = 10;
            asignaturas asigmax = asignaturas.Historia;
            asignaturas asigmin = asignaturas.Historia;

            for (int i = 0; i < notas.GetLength(1); i++)
            {
                if (this[alumno, i] <= min)
                {
                    min = this[alumno, i];
                    asigmin = (asignaturas)i;
                }
                if (this[alumno, i] >= max)
                {
                    max = this[alumno, i];
                    asigmax = (asignaturas)i;
                }
            }
            minimo = min;
            return max;
        }
        public String MostrarTodas(String[] nombres)
        {
            String visual="";
            visual= visual+String.Format("{0,10}", "Alumno");
            foreach (asignaturas asig in Enum.GetValues(typeof(asignaturas)))
            {
                visual = visual + String.Format("{0,10}\t", asig);
            }
            visual = visual + "\n";
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                visual = visual + String.Format("{0,10}", nombres[i]);
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    visual = visual + String.Format(" {0,10}\t", this[i, j]);
                }
                visual = visual +"\n";
            }
            return visual;
        }
        public ArrayList MostrarAprobadas(String[] nombres)
        {
            ArrayList a = new ArrayList();
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                int[] clasificacion = new int[4];
                Boolean aprobado = true;
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    clasificacion[j] = notas[i, j];
                    if (notas[i, j] < 5)
                    {
                        aprobado = false;
                    }
                }
                if (aprobado)
                {
                    a.Add(nombres[i]);
                    for (int x = 0; x < clasificacion.Length; x++)
                    {
                        a.Add(Convert.ToString(clasificacion[x]));
                    }
                }
            }
            return a;
        }
    }
}

