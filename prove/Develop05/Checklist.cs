// public class Checklist : Goal
// {
//     private string _nameGoal;
//     private string _descriptionGoal;
//     private int _pointGoal;

//     private int _timesCheck; //check
//     private int _bonusCheck; //check

//     public void GoalPrompts()
//     {
//         Console.WriteLine("");
//         Console.Write("What is the name of your goal? ");
//         _nameGoal = Console.ReadLine();

//         Console.Write("What is a short description of it? ");
//         _descriptionGoal = Console.ReadLine();
        
//         Console.Write("What is the amount of points associated with this goal? ");
//         string _userPoint = Console.ReadLine();
//         _pointGoal = int.Parse(_userPoint);

//         Console.Write("How many times does this goal need to be accomplished for a bonus? ");
//         string _userTimes = Console.ReadLine();
//         _timesCheck = int.Parse(_userTimes);

//         Console.Write("Whats is the bonus for accomplishing it that many times? ");
//         string _userBonus = Console.ReadLine();
//         _bonusCheck = int.Parse(_userBonus);
//     }

//     public void PutGoalsInList()
//     {
//         string _checkGoalInList = $"[ ] {_nameGoal} ({_descriptionGoal}) -- Currently completed: 0/{_timesCheck}";

//     }
// }