namespace _07_Students_task
{
    // task 16
    public class Group
    {
        public Group(int groupNum, string depName, string grName)
        {
            this.GroupNumber = groupNum;
            this.DepartmentName = depName;
            this.GroupName = grName;
        }

        public int GroupNumber { get; set; }
        public string DepartmentName { get; set; }

        // task 18
        public string GroupName { get; set; }
    }
}
