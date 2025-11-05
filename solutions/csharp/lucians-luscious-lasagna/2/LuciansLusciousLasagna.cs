class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
     public  int ExpectedMinutesInOven(){
         int ovenTime = 40;
         return ovenTime; 
     }

    // TODO: define the 'RemainingMinutesInOven()' method

    public int RemainingMinutesInOven( int actualMin){
       
       

        return 40- actualMin;
        
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int numOfLayers){

        return     numOfLayers *2;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int numLayersAdded , int numOfMinutesInOven){
     
        
        return    (numLayersAdded *2) + numOfMinutesInOven;
    }
}
