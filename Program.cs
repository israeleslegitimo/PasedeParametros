using System;

namespace PasedeParametros
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos un parametro para enviar este es para cambiar un correo
            string correo="juan@gmail.com";
            //imprimimos para ver el correo que deseamos cambiar
             Console.WriteLine("el correo a a cambiar es : "+correo);

            //hacemos la referencia para cambiar el valor del parametro
            Referencia.CambiarCorreo(ref correo);

            //pase de parametros por valor

            //creamos un parametro
            int matricula=19211635;
            int c;


            //imprimimos para ver la matricula
            Console.WriteLine("tu matricula es: "+matricula);

            //llamammos  a un metodo para imprimirlo sin cambiar el valor del original
            cosa.copiadora(in matricula,out c);

            //
            

  
        }
    }
    class Referencia
    {
        //creamos un metodo
        public static void CambiarCorreo(ref  string correo)
        {
            //cambiamos el valor
            correo="domador@gmail.com";
            //imprimimos el nuevo correo
            Console.WriteLine("El nuevo correo es: "+ correo);

        }
    }
     class cosa
     {
        public static void  copiadora(in int matr,out int c)
        {
           
            //matricula=1212;
            Console.WriteLine("sin agregar números: "+matr);

            //esto en el caso de crear la matricula de otro individuo
            c=matr+5212122;

            //imprimimos el valor de la matricula con el cambio echo
            Console.WriteLine("con el cambio de número: "+c);





        }
     }
}

     
        
           



    

