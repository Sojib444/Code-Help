

int[] num1 = { 1, 2, 5, 7 };
int[] num2 = { 4, 5 };

List<int> num =  new List<int>();

int i = num1.Length - 1;
int j = num2.Length - 1;

int carry = 0;

while(i >= 0 && j >= 0)
{
    int sum = num1[i] + num2[j] + carry;

    num.Add(sum % 10);
    carry = sum / 10;

    i--;
    j--;
}

while(i >= 0)
{
    int sum = num1[i] + carry;

    num.Add(sum % 10);
    carry = sum / 10;

    i--;
}

while (j >= 0)
{
    int sum = num2[j] + carry;

    num.Add(sum % 10);
    carry = sum / 10;

    j--;
}

for(int k = num.Count - 1; k >= 0; k--)
{
    Console.Write(num[k]);
}