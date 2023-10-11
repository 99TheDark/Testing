package main

type Holder interface {
	intLike() int
}

type SliceHolder struct {
	x int
	y []bool
}

type SlicePtrHolder struct {
	x int
	y *[]bool
}

func (s SliceHolder) intLike() int    { return s.x }
func (s SlicePtrHolder) intLike() int { return s.x }

func main() {
	h1 := SliceHolder{
		9,
		[]bool{true, false},
	}
	h2 := SlicePtrHolder{
		-2,
		&[]bool{false},
	}

	m := map[Holder]string{}

	// comment out line below
	m[h1] = "non pointer"
	m[h2] = "pointer"
}
