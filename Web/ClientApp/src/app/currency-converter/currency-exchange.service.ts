import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { environment } from "../../environments/environment";

@Injectable({ providedIn: "root" })
export class CurrencyExchangeService {
	constructor(private readonly http: HttpClient) { }

	get(data: any): any {
		const url = environment.apiCurrencyExchange + `?from=${data.from}&to=${data.to}&value=${data.value}`;
		return this.http.get(url, data);
	}
}
