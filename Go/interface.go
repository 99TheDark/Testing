package main

import "fmt"

type super interface {
	foo()
}

type inner struct {
	value int
}

type a struct {
	child *inner
	other int
}

type b struct {
	name string
}

func (a a) foo() {
	fmt.Println(a.child.value, a.other)
}
func (b b) foo() {
	fmt.Println(b.name)
}

func change(s super) {
	if a, ok := s.(a); ok {
		a.child.value = 10
		a.other = 6
	}
}

func main() {
	test := super(a{&inner{25}, 12})
	change(test)
	test.foo()
}
