public static class FileFunctions
{
    public static void SaveToFile(int points, List<Goal> goals)
    {
        string fileName;
        Console.Write("Please enter your file name: ");
        fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(points);
            foreach(Goal g in goals)
            {
             outputFile.WriteLine(g.OutputGoalToFileString());   
            }
        }   
    }

    public static int LoadFromFile(List<Goal> goals)
    {
        bool fileLoaded;
        int points = 0;
        string fileName;
        List<string> lines = new List<string>();
        do
        {
            Console.Write("Please enter your file name: ");
            fileName = Console.ReadLine();
            //Checks to see if file exists, wont continue until real file is presented.
            if (File.Exists(fileName))
            {
                lines = System.IO.File.ReadAllLines(fileName).ToList();
                bool firstLine = true;
                foreach(string line in lines)
                {
                    if(firstLine)
                    {
                        points = int.Parse(line);
                        firstLine = false;
                    }
                    else
                    {
                        switch (line[0])
                        {
                            case '1':
                                Console.Read();
                                SimpleGoal sg = new SimpleGoal();
                                sg.LoadGoalFromFileLine(line);
                                goals.Add(sg);
                                break;
                            case '2':
                                EternalGoal eg = new EternalGoal();
                                eg.LoadGoalFromFileLine(line);
                                goals.Add(eg);
                                break;
                            case '3':
                                TallyGoal tg = new TallyGoal();
                                tg.LoadGoalFromFileLine(line);
                                goals.Add(tg);
                                break;
                        }
                    }
                }
                fileLoaded = true;
            }
            else
            {
                Console.WriteLine($"The goals file \"{fileName}\" does not exist.");
                fileLoaded = false;
            }
        }while(!fileLoaded);
        return points;
    }
}