package main

import "fmt"

func main() {
	var arr [3]string // ew, [3]string instead of string[3]
	arr[0] = "Hello"
	arr[1] = "Dudes"
	arr[2] = "Sup"

	digitsOfPi := [10]int{3, 1, 4, 1, 5, 9, 2, 6, 5, 3}

	fmt.Println(arr, digitsOfPi)
}
