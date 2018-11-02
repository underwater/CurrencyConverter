import { Routes } from "@angular/router";

export const ROUTES: Routes = [
	{ path: "currency-converter", loadChildren: "./currency-converter/currency-converter.module#CurrencyConverterModule" },
	{ path: "", redirectTo: "currency-converter", pathMatch: "full" },
	{ path: "**", redirectTo: "currency-converter" }
];
