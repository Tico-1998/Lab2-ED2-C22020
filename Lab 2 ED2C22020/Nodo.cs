using System;
using System.Security.Cryptography.X509Certificates;

public class Nodo
{
	int contadornodos = 0;
	public var id;
	public Nodo padre;
	public Nodo[] hijo;
	public T[] valor;
	public bool raiz;
	public Nodo(T)
	{
		int minimo = (5 / 2) - 1;
		//definir tamaño del nodo

		public void insert(T)
        {
			//buscar nodo raiz
			//ver en que nodo se esta trabajando si es el nodo que corresponde o si es padre etc.
			Nodo nodo = new Nodo(T);
			bool espacio = true;
            for (int i = 0; i < 3; i++)
            {
				if (nodo.valor[i] != null)
				{
					nodo.valor[i] = T;
					espacio = false;
					//ordenar lista 
				}
            }
			if (espacio)
			{
				if (nodo.padre == null)
				{
					nodo.valor[4] = T;
					//ordenar lista
					Nodo nodohermano = new Nodo(T);
					contadornodos++;
					nodohermano.id = contadornodos;
					nodohermano.padre = (contadornodos + 1);
					nodohermano.valor[0] = nodo.valor[3];
					nodo.valor[3] = null;
					nodohermano.valor[1] = nodo.valor[4];
					nodo.valor[4] = null;
					contadornodos++;
					Nodo padre = new Nodo(T);
					padre.id = contadornodos;
					padre.hijo[0] = (contadornodos - 2);
					padre.hijo[1] = (contadornodos - 1);
					padre.valor[0] = nodo.valor[2];
					padre.padre = true;
					nodo.padre = false;
					nodohermano.padre = false;
					nodo.valor[2] = null;
				}
				else
                {
					nodo.valor[4] = T;
					//ordenar lista
					Nodo hermano = new Nodo(T);
					contadornodos++;
					hermano.id = contadornodos;
					hermano.padre = nodo.padre;
					hermano.valor[0] = nodo.valor[3];
					nodo.valor[3] = null;
					hermano.valor[1] = nodo.valor[4];
					nodo.valor[4] = null;
					padre.insert(T);//revisar si funciona recursividad					
                }
			}
        }
		public void delete(T)//ver id para eliminar por id 
        {
			bool underflow = false;
			//posicionar en raiz 
			Nodo nodo = new Nodo(T);
			bool encontrado = false;
			int contador = -1;
            do
            {
				contador++;
				if(nodo.valor[contador]=T)
                {
					nodo.valor[contador] = null;
					encontrado = true;
						
                }
            } while (nodo.valor[contador+1]!=null | encontrado);
			if(!encontrado)
            {
                for (int i = 0; i < 5; i++)//revisar otra manera para llegar a los hijos 
                {
					nodo.hijo[i].delete;
				}
            }
			////////////////////////////////////////////////////////////////////////////
			///
			int cantidadvalores = nodo.valor.count();
			//contar elementos de la lista
			
			if(minimo>cantidadvalores)
            {
				underflow = true;
            }
			if(underflow)
            {
				//corregir underflow
            }
        }
		public void InOrden(Nodo(T))//el valor que se recibe es la raiz
        {
			//ubicar raiz 
			Nodo raiz = new Nodo(T);
			Nodo nodohijo = new Nodo(T);
			if(raiz.hijo[0]!=null)
            {
				nodohijo = raiz.hijo[0];
				InOrden(nodohijo);
            }
			else
            {
				//Escribir valores del nodo
				raiz = nodohijo.padre;				
				//escribir raiz.valor[0];
				if(raiz.hijo[1]!=null)
                {
					nodohijo = raiz.hijo[1];
					InOrden(nodohijo);
                }
				else
                {
					//Escribir valores del nodo
					raiz = nodohijo.padre;
                    //escribir raiz.valor[1];
                    if (raiz.hijo[2]!=null)
                    {
						nodohijo = raiz.hijo[2];
						InOrden(nodohijo);
                    }
					else
                    {
						//escribir valores del nodo
						raiz = nodohijo.padre;
                        //Escribir raiz.valor[2];
                        if (raiz.hijo[3]!=null)
                        {
							nodohijo = raiz.hijo[3];
							InOrden(nodohijo);
                        }
						else
                        {
							//escribir valores del nodo
							raiz = nodohijo.padre;
                            //escribir raiz.valor[3];
                            if (raiz.hijo[4]!=null)
                            {
								nodohijo = raiz.hijo[4];
								InOrden(nodohijo);
                            }
                            else
                            {
								//escribir valor del nodo
                            }
                        }
                    }
				}
			}

        }
		public void PreOrden(Nodo(T))
        {
			Nodo Raiz = new Nodo(T);
			//imprimir valor 
			Nodo nodohijo = new Nodo(T);
            if (Raiz.hijo[0]!=null)
            {
				nodohijo = Raiz.hijo[0];
				PreOrden(nodohijo);
            }
            else if (Raiz.hijo[1]!=null)
            {
				nodohijo = Raiz.hijo[1];
				PreOrden(nodohijo);
            }
            else if (Raiz.hijo[2]!=null)
            {
				nodohijo = Raiz.hijo[2];
				PreOrden(nodohijo);
            }
			else if (Raiz.hijo[3]!=null)
            {
				nodohijo = Raiz.hijo[3];
				PreOrden(nodohijo);
            }
            else if (Raiz.hijo[4]!=null)
            {
				nodohijo = Raiz.hijo[4];
				PreOrden(nodohijo);
            }
        }
		public void PostOrden(Nodo(T))
        {
			Nodo raiz = new Nodo(T);
			Nodo nodohijo = new Nodo(T);
			if(raiz[0]!=null)
            {
				nodohijo = raiz[0];
				PostOrden(nodohijo);
            }
			else if(raiz[1]!=null)
            {
				nodohijo = raiz[1];
				PostOrden(nodohijo);
            }
			else if(raiz[2]!=null)
            {
				nodohijo = raiz[2];
				PostOrden(nodohijo);
            }
			else if(raiz[3]!=null)
            {
				nodohijo = raiz[3];
				PostOrden(nodohijo);
            }
			else if(raiz[4]!=null)
            {
				nodohijo = raiz[4];
				PostOrden(nodohijo);
            }
			else
            {
				//escribir valores 
            }
        }
		
	}
}
