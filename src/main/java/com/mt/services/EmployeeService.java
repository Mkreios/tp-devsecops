package com.mt.services;

import java.util.HashMap;
import java.util.Map;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.ResponseBody;

@Controller
@RequestMapping("/employee")
public class EmployeeService {

    @GetMapping("/getEmployeeDetails")
    @ResponseBody
    public Map<String, Object> getEmployeeDetails() {

        Map<String, Object> response = new HashMap<>();
        response.put("Name", "Mithun Technologies");
        response.put("Calling Name", "Mithun");
        response.put("DOB", "08-Nov-2011");
        response.put("Hobbies", "Reading Technical Blogs, Teaching, Helping Poor People");
        response.put("Places he like", "His native place");

        return response;
    }
}
