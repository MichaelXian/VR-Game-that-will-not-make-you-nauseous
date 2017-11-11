using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class notfor : MonoBehaviour {
	public Light L;

	float r;
	float g;
	float b;
	int cur;
	int speed;
	int cap;
	Action[] fns; 
	// Use this for initialization
	void Start () {
		cur = 0;
		r = 255;
		g = 0;
		b = 0;
		speed = 5;
		cap = 200;
		L = GetComponent<Light>();
		fns = new Action[] {()=> fn0(), ()=> fn1(), ()=> fn2(), ()=> fn3(), ()=> fn4(), ()=> fn5()};
	}
		
	// Update is called once per frame
	void Update () {
		fns [cur]();
		//print(ToString(r) + " " + ToString(g) + " " + ToString(b));
		print (r);
		print (g);
		print (b);
		L.color = new Color(r/255, g/255, b/255, 1);
	}

	void fn0() {
		g += speed;
		if (g >= cap) {
			g = 255;
			cur++;
		}
	}

	void fn1() {
		r -= speed;
		if (r <= 0) {
			r = 0;
			cur++;
		}
	}

	void fn2() {
		b += speed;
		if (b >= cap) {
			b = 255;
			cur++;
		}
	}

	void fn3() {
		g -= speed;
		if (g <= 0) {
			g = 0;
			cur++;
		}
	}

	void fn4() {
		r += speed;
		if (r >= cap) {
			r = 255;
			cur++;
		}
	}

	void fn5() {
		b -= speed;
		if (b <= 0) {
			b = 0;
			cur = 0;
		}
	}

}
