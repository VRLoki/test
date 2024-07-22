int fact(int f) {
  if (f == 1 || f <= 0) {
    return 1;
  } else {
    return f * fact(f - 1);
  }
}
