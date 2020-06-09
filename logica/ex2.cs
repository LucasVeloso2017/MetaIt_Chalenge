/*

Um bracket é considerado qualquer um dos seguintes caracteres: (, ), {, }, [ ou ].
Dois brackets são considerados um par combinado se o bracket de abertura (isto é, (, [ou {)
ocorre à esquerda de umbracket de fechamento (ou seja,),] ou} do mesmo tipo exato. Existem três
tipos de pares de brackets : [], {} e ().

Um par de brackets correspondente não é balanceado se o de abertura e o de fechamento não 
corresponderem entre si. 
Por exemplo, {[(])} não é balanceado porque o conteúdo entre {e} não é balanceado. O primeiro 
bracket inclui o de abertura, (, e o segundo inclui um bracket de fechamento desbalanceado,].
Dado sequencias de caracteres, determine se cada sequência de brackets é balanceada. Se uma 
string estiver balanceada, retorne SIM. Caso contrário, retorne NAO.

*/

static string balanced(string s) {

    if (s == string.Empty){
        return "YES";
    }

    Stack<char> stack = new Stack<char>();

    char c;
    for (int i = 0; i < s.Length; i++){
        c = s[i];

        if (c == '('){

          stack.Push(c);
        
        }else if (c == '{'){

          stack.Push(c);
        
        }else if (c == '['){

          stack.Push(c);
        
        }else if (c == ')'){
            if (stack.Count == 0){
                return "NO";
        
            }else if (stack.Peek() == '('){
            
                stack.Pop();
            
            }else{
            
                return "NO";
            
            }else if (c == '}'){
                if (stack.Count == 0){
                
                    return "NO";
                
                }else if (stack.Peek() == '{'){
                 
                    stack.Pop();
                
                }else{
                   
                    return "NO";
                
                }else if (c == ']'){
                    if (stack.Count == 0){
                        return "NO";
                    }else if (stack.Peek() == '['){
                        stack.Pop();
                    }else{
                        return "NO";
                    }
                }
            }
        }
    }               
    return stack.Count == 0 ? "YES" : "NO";
}