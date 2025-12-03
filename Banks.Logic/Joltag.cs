namespace Banks.Logic;

public class Joltage
{
    public int maxBankJoltage(string bankString) {
        int first_digit = 0; // 1
        int second_digit = 0; // 1
        int second_digit_canidate; // 1

        // When we find a digit >= first_digit, the old first_digit
        // becomes a candidate for second_digit.

        for (int i = bankString.Length - 1; i >= 0; i--) {
            if (bankString[i] >= first_digit) {
                second_digit_canidate = first_digit;
                if (second_digit_canidate >= second_digit) {
                    second_digit = first_digit;
                    first_digit = bankString[i];
                }
            }
        }

        int res = int.Parse($"{first_digit}{second_digit}");
        return res;
    }
}
