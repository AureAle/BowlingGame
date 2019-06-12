using System;

namespace magma
{
    class Bowling
    {

            
        private static int[] pinsTirados = new int[]{1,4,4,5,6,4,5,5,10,0,0,1,7,3,6,4,10,0,2,8,6};
        private static int contadorTurno = 0;
      
        static void Main(string[] args)
        {
            
            Console.WriteLine("TotalScore: "+ Score());
            
            
        }

        public static void Turno(int pins){
            if(pins==10){
                contadorTurno++;
            }
            pinsTirados[contadorTurno++] = pins;

        }

        public static int Score(){
           int totalScore =0;

           for(int i=0;i<pinsTirados.Length;i++){
               if(pinsTirados[i]==10){//strike
                   totalScore += pinsTirados[i+1] + pinsTirados[i+2];

               }
               else if(i>0 && i % 2 ==1){
                   int scoreTurno = pinsTirados[i] + pinsTirados[i-1];
                   if(scoreTurno==10){//spare
                       totalScore+=pinsTirados[i+1];
                   }
               }
               totalScore += pinsTirados[i];
           }
           return totalScore;
        }



    }
}
