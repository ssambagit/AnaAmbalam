class BirdCount
{
    private int[] birdsPerDay;
   

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] lastweek =  {0,2,5,3,7,8,4};
        
        foreach (int i in lastweek)
        {    
         Console.WriteLine("last week birds list"+i);
        }    
        return lastweek;
    }
////////////////////////////////////////////////////////////
    public int Today()
    {
      
    return birdsPerDay[birdsPerDay.Length-1];
    }
/////////////////////////////////////////////////////////////
    public void IncrementTodaysCount()
    {
      
        int birdadded= birdsPerDay[birdsPerDay.Length-1]+=1;
        Console.WriteLine(birdadded);
    }
/////////////////////////////////////////////////////////////
    public bool HasDayWithoutBirds()
    {
       // int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
           bool yes = false;
        for(int i=0; i<birdsPerDay.Length-1; i++){
                     
            if(birdsPerDay[i]==0){
              
                yes=true;
                break;
            }
       
        }
         return yes;
    }
////////////////////////////////////////////////////////////
    public int CountForFirstDays(int numberOfDays)
    {
   
   Console.WriteLine("CountForFirstDays:",birdsPerDay[0]);
        int sum = 0;
        for(int i=0; i<= numberOfDays-1; i++){
            sum+= birdsPerDay[i];
        }
        return sum;
    }

    public int BusyDays()
    {
    
        int busyDays = 0;
         for(int i=0; i <birdsPerDay.Length-1; i++){
        {
            if(birdsPerDay[i]>=5)
            {
                busyDays++;
            }
        }
       
       }
         Console.WriteLine("busyDays:"+busyDays);
        return busyDays;
}
}