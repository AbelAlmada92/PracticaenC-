using System;

namespace practica4
{ 
    internal class program 
    {
        static void Main(string[] args)
        {
            int [] Ncuenta = new int [4];
            char[] tipoC = new char[4];
            float[] saldo = new float[4];
            int [] rojo = new int[4];

            int Ncuenta2, k, i, c, x, aux1;
            char DE, aux2;
            float Mdo, aux;

            for(i=0; i<4; i++)
            {
                Console.WriteLine("Ingrese su numero de cuenta: ");
                Ncuenta[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su tipo de cuenta C o U: ");
                tipoC[i] = char.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su saldo en la cuenta: ");
                saldo[i] = float.Parse(Console.ReadLine());
            
            }
            Console.WriteLine("Datos ingresados correctamete. ");
            Console.WriteLine("Ingrese su cuenta. ");
            Ncuenta2 = int.Parse(Console.ReadLine());

            while(Ncuenta2 !=0)
            // BUSQUEDA
            {
                k = 0;
                i = 0;

                while(k==0 && i<100)
                {
                    if(Ncuenta2 == Ncuenta[i])
                    {
                       k =1;
                    }
                    else
                    {
                        i++;
                    }

                    if(k == 0)
                    {
                        Console.WriteLine("Indique tipo de de operacion D o E");
                        DE = char.Parse(Console.ReadLine());
                        Console.WriteLine("Indique el monto: ");
                        Mdo = float.Parse(Console.ReadLine());

                        if(DE == 'D' || DE == 'd')
                        {
                           saldo[i] +=Mdo;
                        }
                        else
                        {
                            if(DE =='E' || DE == 'e')
                            {
                             if(Mdo <= saldo[i])
                             {
                               saldo[i] -= Mdo;
                             } 
                            }   
                            else 
                                if(tipoC[i] == 'U' || tipoC[i] == 'u')
                                {
                                  saldo[i] -= Mdo;
                                }
                            else
                            {
                               Console.WriteLine("Saldo insuficiente. ");
                            }
                        }
                   }
                   Console.WriteLine("Ingrese su cuenta: ");
                   Ncuenta2 = int.Parse(Console.ReadLine());
                }
                // GENERACION CON NUMEROS EN ROJO.
                c=0;
                for(i=0; i<4; i++)
                {
                    if(saldo[i]<0)
                    {
                        rojo[c]= Ncuenta[i];
                        c++;
                    }
                }

                if(c==0)
                {
                    Console.WriteLine("No hay cuenta en ROJO. ");
                }

                else
                {
                    for(i=0; i< c; i++)
                    {
                     //INFORME DE CUENTA EN ROJO.
                       Console.WriteLine("Las cuentas con saldo negativo son: " +rojo[i]);
                     //ORDENAMIENTO
                     k = 0;
                     x = 4;

                     while (k == 0)
                     {
                         k = 1;
                         x --;

                         for(i=0; i<x; i++)
                         {
                            if(saldo[i] > saldo[ i + 1])
                            {
                             // COMPARACION DE VECTOR DEL TIPO SALDO
                                aux = saldo[i];
                                saldo[i]= saldo[i + 1];
                                saldo [i + 1] = aux;

                             // COMPARACION DEL VECTOR NCUENTA 
                                aux1= Ncuenta[i];
                                Ncuenta[i] = Ncuenta[i + 1];
                                Ncuenta[i + 1] = aux1;

                             //COMPARACION DEL VECTOR TIPOC
                                aux2= tipoC[i];
                                tipoC[i] = tipoC[i + 1];
                                tipoC[i + 1] = aux2;

                                k=0;
                            }
                          }
                       }    
                    }

                    for(i=0; i<4; i++)
                    {
                        //INFORME DEL VECTOR ORDENADO.
                        Console.WriteLine("Numero de cuenta: " +Ncuenta[i]);
                        Console.WriteLine("Tipo de cuenta: " +tipoC[i]);
                        Console.WriteLine("Saldo de cuenta: " +saldo[i]);
                    }
                }    
            }

        }
    }
}