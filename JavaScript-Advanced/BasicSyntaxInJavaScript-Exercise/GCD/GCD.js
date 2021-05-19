function solution(x, y) {
   
    x = Math.abs(x);
    y = Math.abs(y);

    while(y) {
      var t = y;
      y = x % y;
      x = t;
    }

    return x;
  }

  console.log(solution(2154,2));
  
 