import React from 'react';

const Answer = (props) => {
	return (
		<div id={props.id} className='answer'>
			{/*call handleCheckboxChange function when checked*/} 
			<input checked={props.checked} type='checkbox' onChange={props.handleCheckboxChange} />
            <div className='text'>{props.text}</div>
		</div>
	);
};

export default Answer;