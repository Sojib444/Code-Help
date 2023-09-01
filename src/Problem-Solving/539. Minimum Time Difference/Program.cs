
List<string> date = new List<string>(){ "23:59", "00:00" };

List<int> minutes = new List<int>();

for(int i = 0;i < date.Count; i++)
{
    string[] time = date[i].Split(':');

    int hour = int.Parse(time[0]);
    int minute = int.Parse(time[1]);

    int totalMinute = hour * 60 + minute;

    minutes.Add(totalMinute);
}

var result = minutes.Order().ToList();

int min = int.MaxValue;

for(int i = 0; i < result.Count-1; i++)
{
    if (result[i+1] - result[i] < min)
    {
        min = result[i + 1] - result[i];
    }
}

int dif = (result[0] + 1440) - result[result.Count - 1];

if(dif < min)
{
    min = dif;
}

Console.WriteLine(min);



