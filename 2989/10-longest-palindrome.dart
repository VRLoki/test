String longestPalindrome(String s) {
  String longest = "";
  for (int i = 0; i < s.length; i++) {
    for (int j = i + 1; j <= s.length; j++) {
      String substring = s.substring(i, j);
      if (isPalindrome(substring) && substring.length > longest.length) {
        longest = substring;
      }
    }
  }
  return longest == "" ? "none" : longest;
}

bool isPalindrome(String s) {
  if (s.length < 3) {
    return false;
  }
  String reversed = s.split('').reversed.join('');
  return s == reversed;
}
