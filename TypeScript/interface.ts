interface Person {
    name: string,
    age: number,
    tired: boolean
}

function isTired(person: Person) : boolean {
    return person.tired;
}

console.log(isTired({
    name: "TheDark",
    age: 14,
    tired: true
}))
