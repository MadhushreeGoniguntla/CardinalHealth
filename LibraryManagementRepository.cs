public class LibraryManagementModel
{

//Check Out items using user/member Id
public void CheckOutItems(List<Item> items, int memberId)
{
  List<IssueStatus> issueItems = new List<IssueStatus>();
  IssueStatus issueItem;
  
    For each item in items
    {
    issueItem = new IssueStatus();
    
    //Fill all properties in issueItem
    .
    .
    .
    
    //Calculate Due date for the Items
    //Get CheckOutDays Limit from Item Type table for the item chosen
    issueItem.DueDate = CurrentDate + CheckOutDaysLimit;
    issueItem.MemberId = memberId;
    
    issueItems.Add(issueItem);
       
    }
    
    //Save issueItems to Db;

}

//Get Items that are already checked out and the user who has checked out
public List<IssueStatus> GetCheckedOutItems()
{

//If return date is null, item remains checked out

var checkedOutItems =  Select I.MemberId, M.MemberName, T.ItemName from IssueStatus I 
                      join Item T on I.ItemTypeId = T.ItemTypeId 
                      join Member M on M.MemberId = I.MemberId
                        where I.ReturnDate = null
return checkedOutItems;       
             
}

//Get users/members how have over due items & the fine for them
public dynamic GetOverdueUsers()
{
  OverDueItems = Get Items from Issue Status where Due Date < Current date and Return Date = null

  return CalculateFine(OverDueItems) ;

}

//Calculate Fine for the due item
private dynamic CalculateFine(List<IssueStatus> items)
{
  For each item in items
  {
    //Get FineAmount from ItemType table for the Item due by user   
    //Fine = DateDiff(DueDate , CurrentDate) * FineAmount
   }
}

//Search for items matching Author name or Title
public List<Item> SearchItems(string searchInput)
{
//Get List of Items where Item.Author like '%searchInput%' Or Item.Title like '%searchInput%'
}

}
