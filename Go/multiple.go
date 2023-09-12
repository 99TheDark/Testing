package main

import "fmt"

func addThemBoth(a int, b int, c int, d int) (int, int) {
	return a + b, c + d
}

func main() {
	sum1, sum2 := addThemBoth(2, 1, 7, 3)

	fmt.Println(sum1, sum2)
}
