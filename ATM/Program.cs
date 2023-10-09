using System;

public class cardHolder
{
    String firstName;
    String lastName;
    String cardNum;
    int pin;
    double balance;

    public cardHolder(String firstName, String lastName, String cardNum, int pin, double balance)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.cardNum = cardNum;
        this.pin = pin;
        this.balance = balance;
    }
}