/*

Dado um array de números inteiros, retorne os índices dos dois números de forma que eles se
somem a um alvo específico.
Você pode assumir que cada entrada teria exatamente uma solução, e você não pode usar o
mesmo elemento duas vezes.

Exemplo:
Dado nums = [2, 7, 11, 15], alvo = 9,
Como nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].

*/

function exercicioUm(){
    
    const nums = [5,10,20,40,50]
    const target = 15

    for(let i = 0 ; i<nums.length;i++){
       if(nums[i] + nums[i + 1] === target){
           const expressao = `${nums[i]+ nums[i + 1]}`
           console.log(expressao) 
       }
    }
}

exercicioUm()