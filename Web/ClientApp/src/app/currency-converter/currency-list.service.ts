import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { environment } from "../../environments/environment";

@Injectable({ providedIn: "root" })
export class CurrencyListService {
	constructor(private readonly http: HttpClient) { }

	get() {
		return this.http.get(environment.apiCurrencyList);
	}
}
