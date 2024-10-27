using Assignment3;
using Task;



List<string> n = new List<string>()
{
    "Y1","Y2","Y3","Y4","G1","G2","G3","G4","B1","B2","B3","B4","R1","R2","R3","R4"
};

int cnt = n.Count(s => s[0] == 'R');
Console.WriteLine(cnt);