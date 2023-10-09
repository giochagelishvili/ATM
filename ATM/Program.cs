using System;
using System.ComponentModel.Design;

public class cardHolder
{
    String firstName; // Cardholder's first name
    String lastName; // Cardholder's last name
    String cardNum; // Card number
    int pin; // Card pin
    double balance; // Balance

    // Constructor
    public cardHolder(String firstName, String lastName, String cardNum, int pin, double balance)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.cardNum = cardNum;
        this.pin = pin;
        this.balance = balance;
    }

    // Getters
    public String getFirstName()
    {
        return firstName;
    }

    public String getLastName()
    {
        return lastName;
    }

    public String getCardNum()
    {
        return cardNum;
    }
    
    public int getPin()
    {
        return pin;
    }

    public double getBalance()
    {
        return balance;
    }

    // Setters
    public void setFirstName(String firstName)
    {
        this.firstName = firstName;
    }

    public void setLastName(String lastName)
    {
        this.lastName = lastName;
    }

    public void setCardNum(String cardNum)
    {
        this.cardNum = cardNum;
    }

    public void setPin(int pin)
    {
        this.pin = pin;
    }

    public void setBalance(double balance)
    {
        this.balance = balance;
    }

    public static void Main(String[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Please choose from one of the following options: ");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show balance");
            Console.WriteLine("4. Exit");
        }

        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much would you like to deposit:");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(deposit);
            Console.WriteLine("Thank you for your deposit. Your new balance is: " + currentUser.getBalance());
        }

        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much would you like to withdraw: ");
            double withdrawal = Double.Parse(Console.ReadLine());

            if (currentUser.getBalance() < withdrawal)
            {
                Console.WriteLine("Insufficient balance: (");
            } else
            {
                currentUser.setBalance(currentUser.getBalance() - withdrawal);
                Console.WriteLine("Thank you!");
            }
        }

        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Current balance: " + currentUser.getBalance());
        }

        List<cardHolder> cardHolders = new List<cardHolder>();

        cardHolders.Add(new cardHolder("Ethan", "Anderson", "4020123456789010", 3827, 150.31));
        cardHolders.Add(new cardHolder("Olivia", "Martinez", "4111222233334444", 5491, 390.31));
        cardHolders.Add(new cardHolder("Liam", "Baker", "4222987654321098", 7264, 921.49));
        cardHolders.Add(new cardHolder("Sophia", "Thompson", "4310246813579021", 1938, 1250.91));
        cardHolders.Add(new cardHolder("Noah", "Murphy", "4404858585858585", 6450, 2150.31));

        Console.WriteLine("Welcome to SimpleATM");
        Console.WriteLine("Please insert your card number: ");

        String cardNum = "";
        cardHolder currentUser;

        while(true)
        {
            try
            {
                cardNum = Console.ReadLine();

                currentUser = cardHolders.FirstOrDefault(a => a.cardNum == cardNum);
                if (currentUser != null)
                {
                    break;
                } else
                {
                    Console.WriteLine("Couldn't recognize the card number. Please try again.");
                }
            } catch
            {
                Console.WriteLine("Couldn't recognize the card number. Please try again.");
            }
        }

        Console.WriteLine("Please enter your pin: ");
        int pin = 0;

        while(true)
        {
            try
            {
                pin = int.Parse(Console.ReadLine());

                if (currentUser.getPin() == pin)
                {
                    break;
                } else
                {
                    Console.WriteLine("Incorrect pin. Please try again.");
                }
            } catch
            {
                Console.WriteLine("Incorrect pin. Please try again.");
            }
        }

        Console.WriteLine("Welcome: " + currentUser.getFirstName());

        int option = 0;

        do
        {
            printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            } catch
            {

            }

            if (option == 1) { deposit(currentUser); } 
            else if (option == 2) { withdraw(currentUser); } 
            else if (option == 3) { balance(currentUser); } 
            else if (option == 4) { break; } 
            else { option = 0; }
        } while (option != 4);
        Console.WriteLine("Thank you. Have a nice day!");
    }
}