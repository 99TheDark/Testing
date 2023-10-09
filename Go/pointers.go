package main

import "fmt"

type Inner struct {
	seen bool
}

type ThingA struct {
	val   *int
	inner *Inner
}

type ThingB struct {
	val   *int
	inner *Inner
}

func main() {
	value := 15
	inner := Inner{false}

	a, b := ThingA{&value, &inner}, ThingB{&value, &inner}

	value = 3
	inner.seen = true

	fmt.Println(value, *a.val, *b.val)
	fmt.Println(inner.seen, a.inner.seen, b.inner.seen)

	// Different addresses, same value
	fmt.Printf("%p\n", &a.val)
	fmt.Printf("%p\n", &b.val)
}
