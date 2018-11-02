import { Component } from "@angular/core";
import { FormBuilder, FormGroup } from "@angular/forms";
import { CurrencyExchangeService } from "./currency-exchange.service";
import { CurrencyListService } from "./currency-list.service";

@Component({ selector: "app-currency-converter", templateUrl: "./currency-converter.component.html" })
export class CurrencyConverterComponent {
	converted: any;
	currencies: any[];
	form: FormGroup;

	constructor(
		private readonly currencyExchangeService: CurrencyExchangeService,
		private readonly currencyListService: CurrencyListService,
		private readonly formBuilder: FormBuilder) {
		this.createForm();
		this.loadData();
	}

	createForm() {
		this.form = this.formBuilder.group({ currencyFrom: [], currencyTo: [], currencyValue: [] });
	}

	loadData() {
		this.currencyListService.get().subscribe((response: any) => { this.currencies = response; });
	}

	clear() {
		this.converted = undefined;
	}

	submit() {
		const data = {
			from: this.form.value.currencyFrom.id,
			to: this.form.value.currencyTo.id,
			value: this.form.value.currencyValue
		};

		this.currencyExchangeService.get(data).subscribe((response: number) => {
			this.converted = {
				symbol: this.form.value.currencyTo.currencySymbol,
				value: response
			};
		});
	}
}
