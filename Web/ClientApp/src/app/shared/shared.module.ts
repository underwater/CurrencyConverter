import { CommonModule } from "@angular/common";
import { HttpClientModule } from "@angular/common/http";
import { NgModule } from "@angular/core";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { InterceptorsModule } from "./interceptors/interceptors.module";

@NgModule({
	exports: [
		CommonModule,
		FormsModule,
		HttpClientModule,
		ReactiveFormsModule,
		InterceptorsModule
	],
	imports: [
		CommonModule,
		FormsModule,
		HttpClientModule,
		ReactiveFormsModule,
		InterceptorsModule
	]
})
export class SharedModule { }
