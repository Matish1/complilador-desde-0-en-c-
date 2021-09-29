using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Compilador1
{
    class UnidadesLexicas
    {
        private readonly Dictionary<string, int> words = new Dictionary<string, int>();
        
        public UnidadesLexicas()
        {
            // Palabras reservadas del lenguaje C
            words.Add("auto", 1);
            words.Add("break", 2);
            words.Add("case", 3);
            words.Add("char", 4);
            words.Add("const", 5);
            words.Add("continue", 6);
            words.Add("default", 7);
            words.Add("do", 8);
            words.Add("double", 9);
            words.Add("else", 10);
            words.Add("enum", 11);
            words.Add("extern", 12);
            words.Add("float", 13);
            words.Add("for", 14);
            words.Add("goto", 15);
            words.Add("if", 16);
            words.Add("int", 17);
            words.Add("long", 18);
            words.Add("register", 19);
            words.Add("return", 20);
            words.Add("short", 21);
            words.Add("signed", 22);
            words.Add("sizeof", 23);
            words.Add("static", 24);
            words.Add("struct", 25);
            words.Add("switch", 26);
            words.Add("typedef", 27);
            words.Add("union", 28);
            words.Add("unsigned", 29);
            words.Add("void", 30);
            words.Add("volatile", 31);
            words.Add("while", 32);

            // no sabes cuanto tiempo van a estar ahi
            words.Add("inline", 33); // desde C99
            words.Add("restrict", 34); // desde C99




            //TODO: agregar estos string representativos del lenguaje
            //Directivas del preprocesador
            words.Add("if", 110);
            words.Add("elif", 111);
            words.Add("else", 112);
            words.Add("endif", 113);
            words.Add("defined", 114);
            words.Add("ifdef", 115);
            words.Add("ifndef", 116);
            words.Add("define", 117);
            words.Add("include", 118);
            words.Add("line", 119);
            words.Add("error", 120);
            words.Add("pragma", 121);



            // Macros de la libreria stdio.h
            // estas funciones no se si estan bien del todo con respecto a la libreria de c
            //Funciones stdio.h
            words.Add("fclose", 130);
            words.Add("feof", 131);
            words.Add("fopen", 132);
            words.Add("freopen", 133);
            words.Add("fflush", 134);
            words.Add("setbuf", 135);
            words.Add("setvbuf", 136);
            words.Add("fread", 137);
            words.Add("fwrite", 138);
            words.Add("fgetc", 139);
            words.Add("fgets", 140);
            words.Add("fputs", 141);
            words.Add("getchar", 142);
            words.Add("gets", 142);
            words.Add("putchar", 142);
            words.Add("puts", 142);
            words.Add("ungetc", 142);

        
            // definiendo los std out, in
            words.Add("printf", 143);
            words.Add("scanf", 143);
            words.Add("vscanf", 123);
            words.Add("vprintf", 123);

            words.Add("ftell", 123);
            words.Add("fgetpos", 123);
            words.Add("fseek", 123);
            words.Add("fsetpos", 123);
            words.Add("rewind", 123);
            words.Add("clearerr", 123);
            words.Add("feof", 123);
            words.Add("ferror", 123);
            words.Add("perror", 123);
            words.Add("remove", 123);
            words.Add("rename", 123);
            words.Add("tmpfile", 123);
            words.Add("tmpnam", 123);


            //Funciones stdlib.h
            //Funciones string.h
            //Funciones conio.h
            //Funciones math.h

            // ultimas implementacion de las palabras
            words.Add("main", 220);
            words.Add("NULL", 227);
            words.Add("EDG", 229);


            /////////////////////////////////////////////////////////
            // Tenemos que agregar los token de Simbolos de Estados
        }
        
        // dado un string de palabra reservada este indica el token de identificacion
        public int getTokenWord(string word)
        {
            // ver en caso de que genere un error devolvemos un 300 
            try
            {
                return words[word];
                
            }
            catch (Exception e)
            {
                Console.WriteLine("No se encuentra: ",e );
            }
            return -1;
        }
        // Esta devuweklve los token de la preferencia de simbolos
        public int getTokenSimbol(string word)
        {
            // si no lo encuentra devolvemos un -1
            // ver en caso de que genere un error devolvemos un 300 
            try
            {
                return words[word];
            }
            catch (Exception e)
            {
                Console.WriteLine("No se encuentra: ", e);
            }
            return -1;
        }
        


    }
}

