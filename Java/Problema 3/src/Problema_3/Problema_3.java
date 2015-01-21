package Problema_3;

public class Problema_3 {

	public static void main(String[] args) {
		int[] numbers = new int[args.length];

        System.out.format("Number of command line parameters = %d\n", args.length);
        //testecase1:verify if array is empty
        /////////////////////////////////////////////////////////////////////////////////
        if (0 == args.length)
        {
            System.out.print("Error: Null size array!\n");
            return;
        }
        /////////////////////////////////////////////////////////////////////////////////
        
        System.out.print("Problema 3\n");
        for (int i = 0; i < numbers.length; i++)
        {
            numbers[i] = Integer.parseInt(args[i]);
            System.out.format("numbers[%d] = [%d]\n", i, numbers[i]);
            //testecase2:verify if the numbers are between 1 and n
            /////////////////////////////////////////////////////////////////////////////////
            if (numbers[i] < 1)
            {
                System.out.print("Error: Array has numbers smaller than 1\n");
                return;
            }
            /////////////////////////////////////////////////////////////////////////////////
            //testecase3:the numbers can`t be bigger than the size of the array
            /////////////////////////////////////////////////////////////////////////////////
            if (numbers[i] > numbers.length)
            {
                System.out.print("Error: number is too big\n");
                return;
            }
        }
        printRepeating(numbers);
    	

}
	private static void printRepeating(int[] numbers)
    {
        int i;

        System.out.print("The repeating elements are: ");

        for (i = 0; i < numbers.length; i++)
        {
            if (numbers[Math.abs(numbers[i])] > 0)
                numbers[Math.abs(numbers[i])] = -numbers[Math.abs(numbers[i])];
            else
               System.out.format(" %d ", Math.abs(numbers[i]));
                
            
        }
               
    }
}
