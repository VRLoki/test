String longestUniqueSubstring(String str) {
  String longestSubstring = "";
  String currentSubstring = "";

  for (int i = 0; i < str.length; i++) {
    if (!currentSubstring.contains(str[i])) {
      currentSubstring += str[i];
      if (currentSubstring.length > longestSubstring.length) {
        longestSubstring = currentSubstring;
      }
    } else {
      int index = currentSubstring.indexOf(str[i]);
      currentSubstring = currentSubstring.substring(index + 1) + str[i];
    }
  }

  return longestSubstring;
}
