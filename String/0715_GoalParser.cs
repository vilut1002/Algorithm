public class Solution {
    public string Interpret(string command) {
        string result = "";
        for(int i=0; i<command.Length; i++){
            if(command[i]=='G'){
                result += 'G';
            }
            else if(command[i]=='('&&command[i+1]==')'){
                result += 'o';
            }
            else if(command[i]=='('&&command[i+1]=='a'&&command[i+2]=='l'&&command[i+3]==')'){
                result += "al";
            }
        }
        return result;
        
    }
}