class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
     public  int ExpectedMinutesInOven(){
         int ovenTime = 40;
         return ovenTime; 
     }

    // TODO: define the 'RemainingMinutesInOven()' method

    public int RemainingMinutesInOven( int actualMin){
       
       int remainingMin = 40 - actualMin;

        return remainingMin;
        
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int numOfLayers){

        return     numOfLayers *2;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int numLayersAdded , int numOfMinutesInOven){
      int prepTime = numLayersAdded *2;
        
        return    prepTime + numOfMinutesInOven;
    }
}
