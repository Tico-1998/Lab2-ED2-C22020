using System;
using System.IO;

namespace Lab_2_ED2C22020
{
    class Program
    {
        static void Main(string[] args)
        {
            char caractersep;
            //leer articulo
            string texto = File.ReadAllText("C:\\Users\\voca9\\Desktop\\API.txt"/*path*/);
            if(texto.Contains('▓'))//219
            {
                if(texto.Contains('≡'))//240
                {
                    if (texto.Contains('¾'))//243
                    {
                        if(texto.Contains('╬'))//206
                        {
                            if(texto.Contains('§'))//245
                            {
                                //enviar mensaje 
                                //recibir caracter del API
                            }
                            else
                            {
                                caractersep = '§';
                            }
                        }
                        else
                        {
                            caractersep = '╬';
                        }
                    }
                    else
                    {
                        caractersep = '¾';
                    }
                }
                else
                {
                    caractersep = '≡';
                }
            }
            else 
            {
                caractersep = '▓';
            }
            
        }
    }
}
