package Problema_2;

public class Problema_2 {

	public static void main(String[] args) {
		int[] numbers = new int[args.length];

        System.out.format("Number of command line parameters = %d\n", args.length);
        //testcase1
        //////////////////////////////////////////////////////////////////////////////////            
        if (0 == args.length)
        {
            System.out.print("Error: Null size array!\n");
            return;
        }
        //////////////////////////////////////////////////////////////////////////////////
        Integer big = 0;
        Integer bigger = 0;
        //testcae2
        //////////////////////////////////////////////////////////////////////////////////
        if (big == null)
        {
            System.out.print("Error: Variable big not Initialized!\n");
        }
        if (bigger == null)
        {
            System.out.print("Error: Variable big not Initialized!\n");
        }
        //////////////////////////////////////////////////////////////////////////////////
        for (int i = 0; i < numbers.length; i++)
        {
            numbers[i] = Integer.parseInt(args[i]);
            System.out.format("numbers[%d] = [%d]\n", i, numbers[i]);
            if (numbers[i]>big)
            {
                big = numbers[i];
                //testcase3
                ///////////////////////////////////////////////////////////////////////////
                if (big < numbers[i])
                {
                    System.out.format("%d is not the biggest number \n", numbers[i]);
                }
                ///////////////////////////////////////////////////////////////////////////
            }
            if (numbers[i]>bigger)
            {
                big=bigger;
            	bigger = numbers[i];
            }
          //testcase4
            ///////////////////////////////////////////////////////////////////////////
            if (bigger < numbers[i])
            {
                System.out.format("%d is not the biggest number \n", numbers[i]);
            }
            ///////////////////////////////////////////////////////////////////////////
        
            //testcase5
            ///////////////////////////////////////////////////////////////////////////
            if (big > bigger)
            {
                System.out.format("%d is too big \n", numbers[i]);
            }
            ///////////////////////////////////////////////////////////////////////////
            
            
        }
        System.out.format("primul element cel mai mare: %d\n", big);
        System.out.format("al doilea element cel mai mare: %d\n", bigger);

	}

}
