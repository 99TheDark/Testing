package main

import "fmt"

type coder struct {
	username     string
	years_coding int
}

// kind of like a class method
func (c coder) decades_coding() float32 {
	// casting => like call function
	return float32(c.years_coding) / 10
}

// pointer usage
func (c *coder) been_a_year() {
	c.years_coding++
}

func main() {
	thedark := coder{username: "TheDark", years_coding: 6}
	simpler := coder{"TheDark", 6}

	fmt.Println(thedark == simpler)
	fmt.Println(thedark.decades_coding())

	thedark.been_a_year()
	fmt.Println(thedark)
}
