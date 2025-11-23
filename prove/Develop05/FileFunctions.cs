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
            //Loops through eachgoal and uses its spesific output to file function to save each one
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
                    //Because the first line is always going to be points, we just do a simple check for it and ignore it after
                    if(firstLine)
                    {
                        points = int.Parse(line);
                        firstLine = false;
                    }
                    else
                    {
                        //A switch statement based off of the first character of each new line, as thats where the goal type is stored
                        switch (line[0])
                        {
                            case '1':
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
                            case '4':
                                MultiplicativeGoal mg = new MultiplicativeGoal();
                                mg.LoadGoalFromFileLine(line);
                                goals.Add(mg);
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