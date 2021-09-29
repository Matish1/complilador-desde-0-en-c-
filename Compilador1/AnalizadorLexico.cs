using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador1
{
    class AnalizadorLexico
    {
        // tabla de contenido de las transisiones:
        private enum table{
            wordIdent,
            numberIdent,
        }



        // Tareas de Analizador lexico
        // Eliminar espacios en blanco
        // Eliminar los comentarios
        // Eliminar tab, \n, \r
        // validar que los simbolos sean validos

        // relacionar las lineas del codigo con errores
        // generar tabla de identificadores

        readonly List<string> listGlobal = new List<string>(); // regresar lista e token
        private int cont_col = 0; //contando la posicion en el archivo columnas
        private int cont_line = 1;// contando la posicion como filas

        public List<string> AnalisisLex(string file)
        {
            // Creamos una unidad lexica como objeto
            UnidadesLexicas ul = new UnidadesLexicas();
            string word = string.Empty;
            char c;

            while (cont_col < file.Length)
            {
                c = file[cont_col];

                // Se puede esperar un identificador o una palabra reservada
                if (c == '_' || char.IsLetter(c)) wordIdentData(file);
                else if (c == '.' || c == '+' || c == '-' || char.IsDigit(c)) numberIdent(file);
                

                switch (c)
                {
                    case ' ':  cont_col++;  break;
                    case '\n': cont_line++; break;
                    case '\r': cont_line++; break;
                    case '\t': cont_col+=4; break;
                    case '(':
                    case ')':
                    case ';':
                    case '=':
                        word += c;
                        listGlobal.Add("Linea: " + cont_line + "\t\t Word:" + word + "\t\tToken: " + ul.getTokenSimbol(word));
                        cont_col++;
                        word = string.Empty;
                        break;
                }

            }
            return listGlobal;
        }

        

        public List<string> AnalisisLexFunction(string file)
        {
            UnidadesLexicas ul = new UnidadesLexicas();
            string word = string.Empty;
            char c;

            while(cont_col < file.Length)
            {
                c = file[cont_col]; 
                if(c == '_' || char.IsLetter(c)) wordIdentData(file); // automata que determina si una palabra reservada o un identificador
                else if()
            }
        }

        // Esta funcion va cambiano los valors de las filas y columnas y agregando detalles de los token
        protected void identAutComponent(string file, int[,] transitionTable) // este es el componente generico
        {
            UnidadesLexicas ul = new UnidadesLexicas();
            char c; // mide los caracter uno por uno
            int state = 0;
            int simbol;
            string word = string.Empty;
            do
            {
                c = file[cont_col];

            } while (true);
        }

        // Este es le automta que va a identificar los numeros enteros y reales
        protected void numberIdent(string file)
        {
            UnidadesLexicas ul = new UnidadesLexicas();
            char c;
            int state = 0;
            int simbol;
            string word = string.Empty;

            int[,] transitionTable = {
                {1, 2,-1,-1, 7, 7},
                {1, 2, 4, 4,-1,-1},
                {3,-1,-1,-1,-1,-1},
                {3,-1, 4, 4,-1,-1},
                {5,-1,-1,-1, 6, 6},
                {5,-1,-1,-1,-1,-1},
                {6,-1,-1,-1,-1,-1},
                {1,-1,-1,-1,-1,-1},
            };

            do
            {
                c = file[cont_col];
                simbol = getSimbolNumber(c);
                if (simbol == -1) break;

                word += c;
                state = transitionTable[state, simbol]; // ver esta sintaxis
                if (cont_col == file.Length - 1) break;
                cont_col++;
            } while (true);


            // Si se quedo en un estado final 
            if (state == 1 || state==3 || state ==5) // ver si esta en el estado final y es valido
            {
                if (word.Contains("."))
                {
                    listGlobal.Add("Linea: " + cont_line + "\t\t Word:" + word + "\t\tToken: " + 302);
                }else
                {
                    listGlobal.Add("Linea: " + cont_line + "\t\t Word:" + word + "\t\tToken: " + 301);
                }
            }
        }

        private int getSimbolNumber(char c)
        {
            if (char.IsDigit(c)) return 0;
            else if (c == '.') return 1;
            else if (c == 'E') return 2;
            else if (c == 'e') return 3;
            else if (c == '+') return 4;
            else if (c == '-') return 5;
            return -1;
        }


        // Esta es la funcion que va a adetectar si es una palabra
        // reservada o un identificador
        protected void wordIdentData(string file)
        {
            UnidadesLexicas ul = new UnidadesLexicas();
            char c;
            int state = 0;
            int simbol;
            string word = string.Empty;

            int[,] transitionTable = {
                {1,-1,1},
                {1,1,1},
            };

            do
            {
                c = file[cont_col];
                simbol = getSimbol(c);
                if(simbol == -1) break;
                
                word += c;
                state = transitionTable[state,simbol]; // ver esta sintaxis
                if (cont_col == file.Length - 1) break;
                cont_col++;
            } while (true);

            if(state == 1) // ver si esta en el estado final y es valido
            {
                listGlobal.Add("Linea: " + cont_line + "\t\t Word:" + word + "\t\tToken: " + ul.getTokenWord(word));
            }
        }
        private int getSimbol(char c)
        {
            if (char.IsLetter(c))     return 0;
            else if (char.IsDigit(c)) return 1;
            else if (c == '_')        return 2;
            return -1;
        }



    }
}
