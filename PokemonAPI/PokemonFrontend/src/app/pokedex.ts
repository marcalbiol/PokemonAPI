export class pokedex {
  id!: number;
  nombre!: string;
  imagen!: string;
  tipo!: string;
  region!: region[]
}


export class region {
  id!: number;
  nombre!: string
}
