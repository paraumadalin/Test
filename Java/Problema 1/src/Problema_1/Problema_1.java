package Problema_1;

public class Problema_1 {

	public static void main(String[] args)
	{
		 int [] numbers = new int[args.length];
		 System.out.print("Number of command line parameters = "+ args.length+"\n");

		 //testcase1:check that the array is not empty
		 ///////////////////////////////////////////////////////////////////////////////////
		 if (0 == args.length)
	            {
			 System.out.print("Error: Null size array!\n");
	                return;
	            }
		 ///////////////////////////////////////////////////////////////////////////////////
		 System.out.print("Problema 1\n");
         //problema 1
         ////////////////////////////////////////////////////////////////////////
         Integer suma = 0;
         //testcase2: check if variable suma is initialized
         //////////////////////////////////////////////////////////////////////////////////
         if (suma == null)
         {
             System.out.print("Error: Variable suma not Initialized!\n");
         }
         //////////////////////////////////////////////////////////////////////////////////
            
		 for (int i = 0; i < args.length; i++){
		        numbers[i] = Integer.parseInt(args[i]);
		        System.out.format("numbers[%d] = [%d]\n", i, numbers[i]);
		        if (numbers[i] % 2 == 0)
                {
                    suma = suma + numbers[i];
                  //testcase3:verify if the summ of the numbers is even
                    //////////////////////////////////////////////////////////////////////////////////
                    if (suma % 2 == 0) 
                    {
                    	System.out.print("The number is even\n");
                    }
                    else
                    	System.out.print("The summ is not even one of the numbers is odd\n");
                    //////////////////////////////////////////////////////////////////////////////////
           
                }
		        //testcase4:verify if the number is even or not
                //////////////////////////////////////////////////////////////////////////////////
                else 
                {
                	System.out.print("number not even\n");
                }
                //////////////////////////////////////////////////////////////////////////////////
           
		        System.out.format("Suma: %d\n", suma);

		    
	}
		 System.out.format("Suma elementelor pare: %d\n", suma);

 }
}
      


	


