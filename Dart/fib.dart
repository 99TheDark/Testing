int fibonacci(int val) {
  if (val <= 1) {
    return 1;
  } else {
    return fibonacci(val - 1) + fibonacci(val - 2);
  }
}

void main() {
  print(fibonacci(10));
}
