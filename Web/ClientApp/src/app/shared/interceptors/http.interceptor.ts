import { HttpHandler, HttpInterceptor, HttpRequest } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable()
export class CustomHttpInterceptor implements HttpInterceptor {
	intercept(request: HttpRequest<any>, next: HttpHandler) {
		let url = request.url;

		if (!url.startsWith("http")) {
			url = document.getElementsByTagName("base").item(0).href + url;
		}

		request = request.clone({ url });

		return next.handle(request);
	}
}
