//Item Details
    public class IssueStatus
    {
        public int IssueId {get; set;}
        public int ItemId {get; set;}
        public int MemberId {get; set;}
        public datetime IssueDate {get; set;}
        public datetime DueDate {get; set;}        
        public datetime ReturnDate {get; set;}                
        public double FinePaid {get; set;}                
    }
