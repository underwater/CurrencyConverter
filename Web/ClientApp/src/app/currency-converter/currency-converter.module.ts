import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { SharedModule } from "../shared/shared.module";
import { CurrencyConverterComponent } from "./currency-converter.component";

const routes: Routes = [
	{ path: "", component: CurrencyConverterComponent }
];

@NgModule({
	declarations: [CurrencyConverterComponent],
	imports: [RouterModule.forChild(routes), SharedModule]
})
export class CurrencyConverterModule { }
