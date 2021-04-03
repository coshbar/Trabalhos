/*
* Have the function AlphabetSoup(str) take the str string parameter being passed and return the string with the letters in alphabetical order (ie. hello becomes ehllo).
* Assume numbers and punctuation symbols will not be included in the string.
*/

import java.util.*; import java.io.*;

class Main {

  public static String StringChallenge(String str) {
    char[] chars = str.toCharArray();
    Arrays.sort(chars);
    str = new String(chars);
    return str;
  }

  public static void main (String[] args) {  
    Scanner s = new Scanner(System.in);
    System.out.print(StringChallenge(s.nextLine())); 
  }

}
