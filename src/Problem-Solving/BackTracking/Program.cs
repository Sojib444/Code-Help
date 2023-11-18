
int[,] arr = { { 1, 0, 0 }, { 0, 1, 1 }, { 0, 1, 1 } };
int tar_x = 2;
int tar_y = 2;

int[,] visit = new int[arr.GetLength(0),arr.GetLength(1)];
visit[0,0] = 1;

int i = 0;
int j = 0;

List<List<char>> ans_list = new List<List<char>>();

void RateInMaze(int[,] arr,int i,int j,int tar_x, int tar_y)
{
    List<char> list = new List<char>();

    //baseCase
    if(arr.GetLength(0)-1 == tar_x && arr.GetLength(1)-1 == tar_y )
    {
        ans_list.Add(list);
    }

    //left
    if(i >= 0)
    {
        if (arr[i-1,j]  == 1)
        {
            visit[i-1,j] = 1;
            list.Add('L');
            
            RateInMaze(arr,i-1,j,tar_x,tar_y);                          
        }
    }

    //right
    if (i < arr.GetLength(0))
    {
        if (arr[i +1, j] == 1)
        {
            visit[i +1, j] = 1;
            list.Add('R');

            RateInMaze(arr, i + 1, j, tar_x, tar_y);
        }
    }

    //up
    if (j-1 >= 0)
    {
        if (arr[i, j - 1] == 1)
        {
            visit[i, j - 1] = 1;
            list.Add('U');

            RateInMaze(arr, i, j - 1, tar_x, tar_y);
        }
    }

    //down
    if (j+1 < arr.GetLength(1))
    {
        if (arr[i,j+1] == 1)
        {
            visit[i, j + 1] = 1;
            list.Add('D');

            RateInMaze(arr,i,j+1,tar_x, tar_y);
        }
    }

    ans_list.Add(list);
}