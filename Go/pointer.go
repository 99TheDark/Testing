package main

import "fmt"

type parent struct {
	c1 child
	c2 child
}

type child interface {
	isChild() bool
}

type red struct {
	x int
}

type blue struct {
	y bool
}

func (r red) isChild() bool  { return true }
func (b blue) isChild() bool { return true }

func generate() *parent {
	p := parent{
		red{6},
		blue{false},
	}
	fmt.Printf("%p %p\n", &p.c1, &p.c2)
	return &p
}

func mapThing(p *parent) map[*child]string {
	m := map[*child]string{}
	m[&p.c1] = "Child #1"
	m[&p.c2] = "Child #2"
	return m
}

func doThing(p *parent, m map[*child]string) {
	fmt.Printf("%p %p\n", &p.c1, &p.c2)
	fmt.Println(m[&p.c1], m[&p.c2])
}

func main() {
	p := generate()
	m := mapThing(p)
	doThing(p, m)
}
