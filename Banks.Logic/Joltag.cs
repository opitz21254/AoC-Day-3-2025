namespace Banks.Logic;

public class Joltage
{
    public int maxBankJoltage(string bankString) {
        int first_digit = 0; // 1
        int second_digit = 0; // 1
        int second_digit_canidate; // 1

        // When we find a digit >= first_digit, the old first_digit
        // becomes a candidate for second_digit.

        for (int i = bankString.Length - 2; i >= 0; i--) {
            int digit = bankString[i] - '0';

            if (digit >= first_digit) {
                second_digit_canidate = first_digit;
                first_digit = digit;

                for (int j = bankString.Length - 1; j > 0; j--) {
                    int digit2 = bankString[j] - '0';

                    if (digit2 >= second_digit) {
                        second_digit = digit2;
                    }
                }
            }
        }

        int res = int.Parse($"{first_digit}{second_digit}");
        return res;
    }
}
