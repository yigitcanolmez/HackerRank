 public static List<int> gradingStudents(List<int> grades)
    {
        var response = new List<int>();
        foreach(int grade in grades)
        {
            int multiple = grade / 5;
            
            int nextMultipleValue = (multiple + 1) * 5;
            
            if(multiple > 6 && (nextMultipleValue - grade) < 3 ){
                response.Add(nextMultipleValue);
            }
            else{
                response.Add(grade);
            }
        }
        return response;

    }
