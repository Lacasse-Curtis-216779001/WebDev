string permission = "Manager";
int level = 10;
string output = "";
if(permission.Contains("Admin")){
    output = level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin User";
}
else if (permission.Contains("Manager")){
    output = level >= 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.";
}
else output = "You do not have sufficient priveleges.";

Console.WriteLine(output);